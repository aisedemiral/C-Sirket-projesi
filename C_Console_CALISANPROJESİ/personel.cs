namespace C_Console_CALISANPROJESİ;

public class personel:calisan

{
    public int SatisMiktari;

    public static int satismiktari()
    {
        return satismiktari();
    }

    public int personelMaasıGetir()
    {
        Maas = AsgariUcret;
        return Maas;
    }

    public int mesailiPersonelMaasıGetir(int kacSaatCalisti)
    {
        int sonuc = Hesaplamalar.SaatlikMesaiUcreti("personel", kacSaatCalisti);
        Maas += sonuc;
        return Maas;
    }
}