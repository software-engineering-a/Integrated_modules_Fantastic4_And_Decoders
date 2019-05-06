using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationnewSE.Models
{
    public class Applyforjob
    {
        
        public void applyjob() {

        }


        public void update_job_applied(int id) {


            Database1Entities o = new Database1Entities();
            Application a = new Application();
            a.userid = 1;
            a.jobid = 1;
            a.Id = 2;

            o.Applications.Add(a);


        }

        public List<String> CheckForResumeCompletion()
        {
            bool check = false;
           
            Database1Entities o = new Database1Entities();
            
            ResumeCreation3 r = new ResumeCreation3();
           



            using (Database1Entities context = new Database1Entities())
            {

                return (from x in context.ResumeCreation3
                        where x.RC3Id==1
                        select x.ResumeStatus).ToList();
            }

                //return check;

        }
    }
}