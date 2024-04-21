namespace HW8
{
    public interface IOutput
    {
        public void Show();
        public void Show(string info);
    }

    public interface IMath
    {
        public int Max();
        public int Min();
        public float Avg();
        public bool Search(int valueToSearch);
    }

    public interface ISort
    {
        public void SortAsc();
        public void SortDesc();
        public void SortByParam(bool isAsc);
    }
}
