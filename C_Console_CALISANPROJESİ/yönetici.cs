using System.Text.Json.Serialization;

namespace C_Console_CALISANPROJESİ;

public class yönetici:calisan

{
    public int yoneticiMaasGetir()
    {
         Maas = AsgariUcret*2;
        return Maas;
    }

    public int yoneticiMesailiMaasUcretiGetir(int kacSaatCalisti)
    {
    int sonuc = Hesaplamalar.SaatlikMesaiUcreti("yönetici", kacSaatCalisti);
    Maas +=sonuc;
    return Maas;
    }
}