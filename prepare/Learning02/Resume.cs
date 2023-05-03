public class Resume {
        public string _name;
        public List<Job> _jobs;

        public Resume(string name = null, List<Job> jobs = null){
            _name = name;
            _jobs = jobs;
        }
        public void Display() {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Jobs:");
            foreach (Job value in _jobs){
                value.Display();
            }
        }
    }