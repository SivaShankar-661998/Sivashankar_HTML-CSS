using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingNew
{
    /// <summary>
    /// Ticket class used for stores the ticket detail
    /// </summary>
    class Ticket
    {
        private static int ticketId = 1000;
        public MovieList movieName { get; set; }
        public int seatCount{ get; set; }

        public string movieId;
        public Ticket(MovieList movieName,int seatCount) 
        {   
            
            this.movieName = movieName;
            this.seatCount = seatCount;
            this.movieId = "MID" + ticketId.ToString();
            ticketId++;
        }
        
    }
    /// <summary>
    /// MovieList enum method stores the types of movies
    /// </summary>
    public enum MovieList
    {
        jaiBheem=1,
        kanjana,
        chandramugi
    }
}
