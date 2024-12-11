namespace Lab2.Domain;

public class ActivePlayer : Player
{
    public int IdGame { get; set; }
    public int NrPoints { get; set; }
    public PlayerType PlayerType { get; set; }

    public override string ToString()
    {
        return $"Active Player: {{ idPlayer: {Id}, idGame: {IdGame}, nrPoints: {NrPoints}, playerType: {PlayerType} }}";
    }
}

