using System;

public class Job
{
  public string _job;
  public string _company;
  public int _startYear;
  public int _endYear;

  public void DisplayInfo()
        {
            Console.WriteLine($"{_job} ({_company}) {_startYear}-{_endYear}");
        }
}