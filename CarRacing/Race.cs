namespace CarRacing;

public class Race
{
    private Track _track;
    private Car [] _cars;
    private Car _winner = null;




    public Race(Track track, Car[] cars)
    {
        _track = track;
        _cars = cars;

    }




    public Car Start(int delay)
    {
        while (_winner == null)
        {
            _track.MoveCars();
            _track.Print();

            Thread.Sleep(delay);
            _winner = _track.GetWinner();


        }
        return _winner;




    }

}