using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    [Serializable()]
    public class CustomerReview
    {
        public DateTime reviewDate{ get; set; }
        public String customerName { get; set; }
        public String customerEmail { get; set; }
        public String customerContact { get; set; }
        public Dictionary<String,int> customerRatings { get; set; }

        public CustomerReview()
        {
            this.reviewDate = DateTime.Now ;
        }
        public List<CustomerReview> List()
        {
            StreamReader streamReader = new StreamReader("review.txt");
            List<CustomerReview> reviews = new List<CustomerReview>();
            string line = streamReader.ReadLine();
            while (line != null)
            {
                CustomerReview review = (CustomerReview)JsonConvert.DeserializeObject<CustomerReview>(line);
                reviews.Add(review);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            return reviews;
        }

        public static List<CustomerReview> SortByDate(List<CustomerReview> reviews)
        {
            CustomerReview temp;
            for (int j = 0; j <= reviews.Count - 2; j++)
            {
                for (int i = 0; i <= reviews.Count - 2; i++)
                {
                    if (reviews[i].reviewDate > reviews[i + 1].reviewDate)
                    {
                        temp = reviews[i + 1];
                        reviews[i + 1] = reviews[i];
                        reviews[i] = temp;
                    }
                }
            }
            return reviews;
        }

    }
}
