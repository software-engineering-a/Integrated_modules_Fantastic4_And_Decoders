using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationnewSE.Models
{
    public class SearchJob
    {
        public List<JobPost> searchRelevantJob(String skills, String location, String category)
        {
            Database1Entities o = new Database1Entities();
            JobPost j = new JobPost();


            j.Locationn = "lahore";
            j.RequiredSkills = "java";
            j.Designation = "Android developer";
            j.jobTyoe = "full";
            j.Salary = 1200;
            j.StartTime = "9am";
            j.EndTime = "6am";
            j.Title = "Software Engineeer";

            


            o.JobPosts.Add(j);
            o.SaveChanges();



            using (Database1Entities context = new Database1Entities())
            {
                
                return (from x in context.JobPosts
                        where x.Locationn == (location) && x.RequiredSkills == (skills)
                        select x).ToList();
                       
                
              // return context.JobPosts.Where(b ==> b.Location.)
            //    Query for all blogs with names starting with B

            //   var jobs = from b in context.JobPosts
            //              where b.Locationn.Equals(location) && b.RequiredSkills.Equals(skills) && b.Department.Equals(category)
            //              select b.Id;
            }

            //using (Database1Entities context = new Database1Entities())
            //{

              //  var query = from x in

                            }
            //   (SqlCommand)Database1Entities.GetCommand(jobs);

            //var joblist=jobs.ToList();
            //var sqlString = jobs.ToString();
            //return sqlString;

            //              IQueryable<JobPost> jobs1 = jobs;



            //if (jobs1.Any()) {
            ///    jobs1 = jobs1.Select(b => b.Id()).ToList();
            //   return jobs1;
            //}

            //string a = o.JobPosts.Find(location);
            //  return a;
            //                return jobs1;


            //return;


        //}

        public void insertJob()
        {
            Database1Entities o = new Database1Entities();
            JobPost j = new JobPost();

            j.Title = "Android developer";
                j.Designation = "android dev";
                j.Department = "CS";
            j.Id = 1;
            j.Locationn = "lahore";
            j.jobTyoe = "asd";
            j.RequiredSkills = "abc";
            j.Salary = 1231456;
            j.StartTime = "12-21-19";

            o.JobPosts.Add(j);
            o.SaveChanges();


        }

        public String showjob() {
            return "abcdefgh";
        }


    }
}