namespace BeatThis.Game.Controllers
{
    public interface IControllerable
    {
        public void Up();

        public void Left();

        public void Right();

        public void Attack();
        public void Down();
    }
}
