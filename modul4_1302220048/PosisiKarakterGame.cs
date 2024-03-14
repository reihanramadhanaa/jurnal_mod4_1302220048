public class PosisiKarakter 
{
    private Posisi awal;

    public PosisiKarakter ()
    {
        awal = Posisi.berdiri;
    }

    TriggerKarakter[] transisi =
    {
        new TriggerKarakter(Posisi )


    };

}

public class TriggerKarakter
{
    public Posisi posAwal;
    public Posisi posAkhir;
    public Trigger_pos posTrigger;

    public TriggerKarakter(Posisi posAwal, Posisi posAkhir, Trigger_pos posTrigger)
    {
        this.posAwal = posAwal;
        this.posAkhir = posAkhir;
        this.posTrigger = posTrigger;
    }
}