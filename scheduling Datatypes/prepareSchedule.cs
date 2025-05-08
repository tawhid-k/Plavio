using SchedulingWizard.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SchedulingWizard.scheduling_Datatypes
{
    public struct routine
    {
        public List<course> courses;
    }
    public struct course
    {
        public string name;
        public string section;
        public List<coursetime> slots;
    }
    public struct coursetime
    {
        public DateTime start;
        public DateTime end;
        public string day;
    }
    public static class prepareSchedule
    {
        public static List<routine> combinationalSchedules;

        public static void MakeMySchedule (int pos, routine[] r, routine oldRoutine)
        {
            if (oldRoutine.courses.Count == r.Length)
            {
                combinationalSchedules.Add(oldRoutine);
                return;
            }
            if (pos == r.Length) return;
            for (int i = 0; i < r[pos].courses.Count; i++)
            {
                if (addPossible(oldRoutine, r[pos].courses[i]))
                {
                    MakeMySchedule(pos + 1, r, addCourse(oldRoutine, r[pos].courses[i]));
                }
            }
        }
        public static routine addCourse (routine r, course c)
        {
            routine temp = new routine();
            temp.courses = new List<course>();
            for (int i = 0; i < r.courses.Count; i++)
                temp.courses.Add(r.courses[i]);
            temp.courses.Add(c);
            return temp;
        }
        public static bool addPossible (routine r, course c)
        {
            for (int i = 0; i < r.courses.Count; i++)
            {
                for (int j = 0; j < r.courses[i].slots.Count; j++)
                {
                    for (int k = 0; k < c.slots.Count; k++)
                    {
                        if (r.courses[i].slots[j].day == c.slots[k].day)
                        {
                            if (r.courses[i].slots[j].start >= c.slots[k].end || r.courses[i].slots[j].end <= c.slots[k].start)
                                continue;
                            else return false;
                        }
                    }
                }
            }
            return true;
        }
        public static routine addSpecificCourse (string cid)
        {
            database db = new database();
            routine r = new routine();
            r.courses = new List<course>();
            string query = "select * from timing where cid = " + cid;
            course c;
            c.slots = new List<coursetime>();
            coursetime t = new coursetime();
            DataTable dt = db.Table(query);
            bool isMatch;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                isMatch = false;
                c = new course();
                t.day = dt.Rows[i]["day"].ToString();
                t.start = DateTime.Parse(dt.Rows[i]["start"].ToString());
                t.end = DateTime.Parse(dt.Rows[i]["endt"].ToString());

                string AMPM;
                if (t.start.Hour >= 1 && t.start.Hour <= 3)
                {
                    AMPM = t.start.ToString();
                    AMPM = AMPM.Remove(AMPM.Length - 2, 2);
                    AMPM += "PM";
                    t.start = DateTime.Parse(AMPM);
                }
                if (t.end.Hour >= 1 && t.end.Hour <= 5)
                {
                    AMPM = t.end.ToString();
                    AMPM = AMPM.Remove(AMPM.Length - 2, 2);
                    AMPM += "PM";
                    t.end = DateTime.Parse(AMPM);
                }

                for (int j = 0; j < r.courses.Count; j++)
                {
                    if (dt.Rows[i]["sec"].ToString() == r.courses[j].section)
                    {
                        isMatch = true;
                        r.courses[j].slots.Add(t);
                        break;
                    }
                }
                if (isMatch == false)
                {
                    c.slots = new List<coursetime>();
                    c.name = dt.Rows[i]["cname"].ToString();
                    c.section = dt.Rows[i]["sec"].ToString();
                    c.slots.Add(t);
                    r.courses.Add(c);
                }
            }
            return r;
        }
        /*public static void tempShow()
        {
            for (int i = 0; i < combinationalSchedules.Count; i++)
            {
                string msg = "Routine " + (i + 1);
                msg += Environment.NewLine;
                for (int j = 0; j < combinationalSchedules[i].courses.Count; j++)
                {
                    msg += combinationalSchedules[i].courses[j].name;
                    msg += Environment.NewLine;
                    msg += "Section: " + combinationalSchedules[i].courses[j].section.ToString();
                    msg += Environment.NewLine;

                    for (int k = 0; k < combinationalSchedules[i].courses[j].slots.Count; k++)
                    {
                        msg += "Day: " + combinationalSchedules[i].courses[j].slots[k].day.ToString()+" ";
                        msg += "Start: " + combinationalSchedules[i].courses[j].slots[k].start.ToString()+" ";
                        msg += "End: " + combinationalSchedules[i].courses[j].slots[k].end.ToString()+" ";
                        msg += Environment.NewLine;
                    }
                }
                MessageBox.Show(msg);
            }
        }*/
    }
}
