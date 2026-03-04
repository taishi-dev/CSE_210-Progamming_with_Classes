using System.Threading.Tasks.Dataflow;

class Resume
{
    public string _name;
    public List<Job>_jobs;

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:") ;
        foreach(Job job in _jobs)
        {
            Console.WriteLine(job);
            job.DisplayJob();
        }
    }
}