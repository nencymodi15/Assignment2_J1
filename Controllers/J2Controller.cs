using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_J1.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// link to my j2 https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2020/ccc/juniorEF.pdf
        /// </summary>
        /// <param name="p">It takes the number of people will get infected</param>
        /// <param name="n">number of people who have disease</param>
        /// <param name="r">it eill take number of people who will get affected By the people with disease</param>
        /// <returns>Number of days it will take to get P number of people Infected with the disease</returns>
        [Route("api/J2/{p}/{n}/{r}")]
        public string Get(int p, int n,int r)
        {
            int result=1;
            int dayCounter=0;
            int dayoneaffected = r * n;
            result = dayoneaffected;
            while (result < p)
            {
                result = result * result;
                dayCounter++;
            }
            return "To " + p + "get infected by it will take" + dayCounter + " days.";

        }
    }
}
