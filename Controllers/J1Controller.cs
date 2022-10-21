using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_J1.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// link to my J1 Peoblem https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2022/ccc/juniorEF.pdf
        /// </summary>
        /// <param name="BoxofEight">it takes number od boxes which holds 8 cupcakes at a time</param>
        /// <param name="BoxofThree">it takes number od boxes which holds 3 cupcakes at a time</param>
        /// <returns>This program multiply first value with 8 and second input with 3 for cupcakes and then adds them after that 
        /// it minuses the number of students from the out put and displays the number of remaining cupcakes to user</returns>
        [Route("api/CupCakeBoxes/{BoxofEight}/{BoxofThree}")]
        public int Get(int BoxofEight, int BoxofThree)
        {
            int boxofEightvalue = 8;
            int boxodThreeValue = 3;
            int NumberofStudents = 28;
            int totalCupCake, rmainingCupCakes;

            totalCupCake = (BoxofEight * boxofEightvalue) + (BoxofThree * boxodThreeValue);
            rmainingCupCakes = totalCupCake - NumberofStudents;
            return rmainingCupCakes;
        }
    }
}
