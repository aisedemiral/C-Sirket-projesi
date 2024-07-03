namespace C_Console_CALISANPROJESİ;

public static class Hesaplamalar
{
    public static int AsgariUcret()
    {
        return 17002;
    }

    public static int SaatlikMesaiUcreti(string bolumu,int kacSaatCalisti)
    {
        if (bolumu == "Mudur")
        {
            return 10 * kacSaatCalisti;
        }
        else if (bolumu == "Personel")
        {
            return 5 * kacSaatCalisti;
        }
        else
        {
            return 8 * kacSaatCalisti;
        }
    }
    
}