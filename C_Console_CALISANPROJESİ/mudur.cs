namespace C_Console_CALISANPROJESİ;

public class mudur:calisan
{
    private int departmankaarmiktari;

    public int DepartmanKaarMiktari
    {
        get { return departmankaarmiktari; }
        set { departmankaarmiktari = value; }
    }

    public int MaasiGetir()
    {
        Maas = AsgariUcret * 3;
        return Maas;
    }

    public int MesaiUcretiHesapla(int kacSaatCalisti)
    {
        int sonuc = Hesaplamalar.SaatlikMesaiUcreti("Mudur", kacSaatCalisti);
        Maas += sonuc;
        return Maas;
    }
}