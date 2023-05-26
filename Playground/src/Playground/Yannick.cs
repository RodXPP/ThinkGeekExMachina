using System;
using System.Collections.Generic;

public class Yannick
{
    private Dictionary<string, DateTime> jiuJitsuClassSchedule;

    public Yannick()
    {
        this.jiuJitsuClassSchedule = new Dictionary<string, DateTime>();
    }

    public void ScheduleClass(string className, DateTime classTime)
    {
        // This method schedules a jiu jitsu class at a certain time
        if(!this.jiuJitsuClassSchedule.ContainsKey(className))
        {
            this.jiuJitsuClassSchedule[className] = classTime;
        }
        else
        {
            throw new Exception("Class already scheduled");
        }
    }

    public bool IsClassScheduled(string className)
    {
        // This method checks if a certain class is scheduled
        return this.jiuJitsuClassSchedule.ContainsKey(className);
    }

    public DateTime GetClassTime(string className)
    {
        // This method returns the scheduled time of a class
        if(this.jiuJitsuClassSchedule.ContainsKey(className))
        {
            return this.jiuJitsuClassSchedule[className];
        }
        else
        {
            throw new Exception("Class not found");
        }
    }
    
    public int CountClasses()
    {
        // This method returns the number of classes Yannick has scheduled
        return this.jiuJitsuClassSchedule.Count;
    }
}

