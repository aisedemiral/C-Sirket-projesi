using C_Console_CALISANPROJESİ;

mudur mudur1 = new mudur();
mudur1.Adi = "ayse";
mudur1.Soyadi = "demiral";
int maasi  = mudur1.MaasiGetir();
mudur1.Maas = maasi;
mudur mudur2 = new mudur();
mudur2.Adi = "Furkan";
mudur2.Soyadi = "Zadegil";
int furkanMaas = mudur2.MaasiGetir();
mudur2.Maas = maasi;

int mesailiUcretMudur1 = mudur1.MesaiUcretiHesapla(7);
int mesailiUcretMudur2 = mudur2.MesaiUcretiHesapla(30);

Console.WriteLine(mudur1.Adi + " " + mudur1.Soyadi + " saf maaşı :" + maasi + " mesaili ucreti :" + mesailiUcretMudur1);
Console.WriteLine(mudur2.Adi + " " + mudur2.Soyadi + " saf maaşı :" + furkanMaas + " mesaili ucreti :" + mesailiUcretMudur2);


yönetici yönetici = new yönetici();
yönetici.Adi = "sultan";
yönetici.Soyadi = "unutur";
int Maas1 = yönetici.yoneticiMaasGetir();
yönetici.Maas = Maas1;
int mesailiucretyonetici = yönetici.yoneticiMesailiMaasUcretiGetir(kacSaatCalisti: 20);
Console.WriteLine(yönetici.Adi+" "+yönetici.Soyadi+" saf maaşı"+Maas1+"mesaili ücreti:"+mesailiucretyonetici);

personel personel = new personel();
personel.Adi = "şemsettin";
personel.Soyadi = "demiral";
int Maas2 = personel.personelMaasıGetir();
personel.Maas = Maas2;
int mesailiUcretPersonel = personel.mesailiPersonelMaasıGetir(kacSaatCalisti: 6);
Console.WriteLine(personel.Adi+" "+personel.Soyadi+" saf maaşı:"+Maas2+" mesaili ücreti:"+mesailiUcretPersonel);
Console.ReadLine();
