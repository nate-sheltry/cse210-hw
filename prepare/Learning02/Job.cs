public class Job {
        public string _company;
        public string _jobTitle;
        public int? _startYear;
        public int? _endYear;

        public Job(string company = null, string title = null, int? startYear = null, int? endYear = null) {
            _company = company;
            _jobTitle = title;
            _startYear = startYear;
            _endYear = endYear;
        }

        public void Display(){
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }