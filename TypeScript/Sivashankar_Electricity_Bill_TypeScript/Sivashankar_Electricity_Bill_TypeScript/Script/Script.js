var autogeneratedUserId = 1000;
var autogeneratedBillId = 100;
var UserIdValue;
var ElectricBill = /** @class */ (function () {
    function ElectricBill(paramBillPaid, paramDueDate) {
        autogeneratedBillId++;
        this.BillId = "EB" + autogeneratedBillId.toString();
        this.DueDate = paramDueDate;
        this.BillPaid = paramBillPaid;
    }
    return ElectricBill;
}());
var User = /** @class */ (function () {
    function User(paramName, paramMobileNo, paramAddress) {
        this.Bill = new Array();
        autogeneratedUserId++;
        this.UserId = "U" + autogeneratedUserId.toString();
        this.Name = paramName;
        this.MobileNumber = paramMobileNo;
        this.Address = paramAddress;
    }
    return User;
}());
var userDetail = new Array();
function loginPage() {
    var login = document.getElementById("login");
    var home = document.getElementById("home");
    login.style.display = "block";
    home.style.display = "none";
}
function adminPage() {
    var validPage = document.getElementById("adminPage");
    var home = document.getElementById("home");
    validPage.style.display = "block";
    home.style.display = "none";
}
function option() {
    var validPage = document.getElementById("validation");
    var optionPage = document.getElementById("option");
    optionPage.style.display = "block";
    validPage.style.display = "none";
}
function register() {
    var registerPage = document.getElementById("registerPage");
    var login = document.getElementById("login");
    registerPage.style.display = "block";
    login.style.display = "none";
}
function login() {
    var optionPage = document.getElementById("option");
    var home = document.getElementById("home");
    var registerPage = document.getElementById("registerPage");
    registerPage.style.display = "none";
    optionPage.style.display = "none";
    home.style.display = "block";
}
function userLogin() {
    var login = document.getElementById("login");
    var validPage = document.getElementById("validation");
    login.style.display = "none";
    validPage.style.display = "block";
}
function userPay() {
    var pay = document.getElementById("pay");
    var optionPage = document.getElementById("option");
    optionPage.style.display = "none";
    pay.style.display = "block";
    for (var i = 0; i < UserIdValue.Bill.length; i++) {
        var Billvalue = document.getElementById("billPay").innerHTML = (UserIdValue.Bill[i].BillPaid).toString();
        var Duevalue = document.getElementById("DueValuePay").innerHTML = (UserIdValue.Bill[i].DueDate).toString();
    }
}
function addNewUser() {
    var Name = document.getElementById("name").value;
    var PhoneNum = document.getElementById("phoneNo").value;
    var Address = document.getElementById("city").value;
    var obj = new User(Name, +PhoneNum, Address);
    userDetail.push(obj);
    alert("Hi....! " + obj.Name + " your user Id is " + obj.UserId);
}
function billPage() {
    var validPage = document.getElementById("adminPage");
    var billPageInput = document.getElementById("billPage");
    validPage.style.display = "none";
    billPageInput.style.display = "block";
}
function billSubmit() {
    var billPageInput = document.getElementById("billPage");
    billPageInput.style.display = "none";
    var calculatedBill = document.getElementById("calculatedBill");
    calculatedBill.style.display = "block";
    var PreviousUnit = document.getElementById("prevUnit").value;
    var CurrentUnit = document.getElementById("currUnit").value;
    var Date = document.getElementById("date").value;
    var calculationPrice = (CurrentUnit - PreviousUnit) * 5;
    var Billvalue = document.getElementById("bill").innerHTML = calculationPrice.toString();
    var Duevalue = document.getElementById("DueValue").innerHTML = Date.toString();
    var billObj = new ElectricBill(calculationPrice, Date);
    UserIdValue.Bill.push(billObj);
    alert("BillId is " + billObj.BillId + billObj.DueDate);
}
function userHistory() {
    var optionPage = document.getElementById("option");
    optionPage.style.display = "none";
    var historyPage = document.getElementById("historyPage");
    historyPage.style.display = "block";
    for (var i = 0; i < UserIdValue.Bill.length; i++) {
        var Billvalue = document.getElementById("userHistoryPage").innerHTML = (UserIdValue.Bill[i].BillPaid).toString();
        var Duevalue = document.getElementById("userDueDate").innerHTML = (UserIdValue.Bill[i].DueDate).toString();
        var userName = document.getElementById("userNameHistory").innerHTML = (UserIdValue.Name);
    }
}
function billToLogin() {
    var calculatedBill = document.getElementById("calculatedBill");
    var home = document.getElementById("home");
    calculatedBill.style.display = "none";
    home.style.display = "block";
}
function adminLogin() {
    var adminUserId = document.getElementById("userIdAdmin").value;
    var flag = false;
    userDetail.forEach(function (element) {
        if (element.UserId == adminUserId) {
            alert("Welcome for " + element.Name + " login");
            billPage();
            flag = true;
        }
    });
    if (flag == false) {
        alert("Wrong id ");
    }
}