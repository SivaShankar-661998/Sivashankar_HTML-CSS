using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingNew
{
    class Program
    {
        //List for User details
        public static List<User> userArray = new List<User>();
        static User UserIdMain;
        static void Main(string[] args)
        {
            //Default user values
            var user1 = new User("sivashankar", 23, 9876543210);
            var user2 = new User("vasanth", 21, 9044231632);
            userArray.Add(user1);
            userArray.Add(user2);
            Homepage();
        }
        /// <summary>
        /// HomePage method displays the Menu page
        /// </summary>
        public static void Homepage()
        {
            //Menu Page
            string yesOrNo;
            bool flag = false;
            Console.WriteLine("Welcome to the Syncfusion Cinemas");
            Console.WriteLine("---------------------");
            Console.WriteLine("Home");
            Console.WriteLine("---------------------");
            //First do while loop using for get a correct input
            do
            {
                //Second do while loop using for continue a loop
                do
                {
                    Console.WriteLine("1.New user");
                    Console.WriteLine("2.Login");
                    Console.WriteLine("3.Exit");
                    Console.Write("Select the value above :");
                    int userInput = int.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------------");
                    switch (userInput)
                    {
                        case 1:
                            {
                                AddNewUser();
                                break;
                            }
                        case 2:
                            {
                                Login();
                                break;
                            }
                        case 3:
                            {
                                Homepage();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Enter the value input");
                                break;
                            }
                    }
                    do
                    {
                        Console.WriteLine("Do you want to continue say (yes or no) :");
                        yesOrNo = Console.ReadLine().ToLower();
                        if (yesOrNo == "no" || yesOrNo == "yes")
                        {
                            if (yesOrNo == "no")
                            {

                                Console.WriteLine("-----Thank you-----");
                            }
                            else
                            {

                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("please enter a valid input");
                            flag = true;
                        }

                    } while (flag);

                } while (yesOrNo == "yes");
                if (yesOrNo == "no" || yesOrNo == "yes")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("please enter a valid input");
                    flag = true;
                }
            } while (flag);
        }
        /// <summary>
        /// This AddNewUser method used for adding new user to a list
        /// </summary>
        public static void AddNewUser() 
        {
            
            Console.Write("Enter the Name :");
            string name = Console.ReadLine();

            Console.Write("Enter the Age :");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter the Phonenumber :");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            var obj = new User(name, age, phoneNumber);
            userArray.Add(obj);

            //foreach used for diaplays the details of array of userid
            foreach (User userDetail in userArray)
            {
                if (userDetail.UserName==name)
                {
                    Console.WriteLine("User Id : " + userDetail.UserId + "\nName :" + userDetail.UserName + "\nAge :" + userDetail.Age + "\nPhoneNumber :" + userDetail.PhoneNumber);
                    Console.WriteLine("---------------------------------");
                }
            }
        }
        /// <summary>
        /// Login method used for login existing customer
        /// </summary>
        public static void Login()
        {
            Console.WriteLine("Login Page");
            bool Flag = false;
            if (Validate())
            {
                do
                {
                    Console.WriteLine("1.Book tickets");
                    Console.WriteLine("2.Ticket history");
                    Console.WriteLine("3.Exit");
                    Console.WriteLine("Select the value above :");
                    Console.WriteLine("---------------------------------");
                    int userInput = int.Parse(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1:
                            {
                                BookTicket();
                                break;
                            }
                        case 2:
                            {
                                TicketHistory();
                                break;
                            }
                        case 3:
                            {
                                Homepage();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Please enter the valid input");
                                Flag = true;
                                break;
                            }
                    }
                } while (Flag);
            }
            else
            {
                Console.WriteLine("Wrong user Id");
                Console.WriteLine("Get out......");
            }
        }
        /// <summary>
        /// Validation method validate the userid 
        /// </summary>
       public static bool Validate()
        {
            Console.WriteLine("Enter the User Id :");
            string userEnteredId = Console.ReadLine();
            Console.WriteLine("---------------------------------");
            foreach (User userDetail in userArray)
            {
                if (userEnteredId == userDetail.UserId)
                {
                    UserIdMain = userDetail;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// BookTicket method used to select the required movie
        /// </summary>
        public static void BookTicket()
        {
            Console.WriteLine("-----------Book ticket-----------");
            Console.WriteLine("1.JaiBheem");
            Console.WriteLine("2.Kanjana");
            Console.WriteLine("3.Chandramugi");
            Console.WriteLine("Select the value above :");
            Console.WriteLine("---------------------------------");

            MovieList movieName = (MovieList)int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number seat :");
            int noOfSeat = int.Parse(Console.ReadLine());

            var movieData = new Ticket((MovieList)movieName, noOfSeat);
            UserIdMain.TicketList.Add(movieData);
            Console.WriteLine($"Your {movieName} movie ticket {noOfSeat} Seats Booked successfully{movieData.movieId}......");
        }
        /// <summary>
        /// TicketHistory methods displays the History
        /// </summary>
        public static void TicketHistory()
        {
            
            foreach(var detail in UserIdMain.TicketList)
            {
                Console.WriteLine($"UserName : {UserIdMain.UserName} || TicketId : {detail.movieId} || MovieName : {detail.movieName} || SeatCount : {detail.seatCount}" );
            }
 
        }
    }
}

