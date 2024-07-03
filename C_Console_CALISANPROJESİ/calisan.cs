namespace C_Console_CALISANPROJESİ;

public class calisan
{
    private string adi;
    private string soyadi;
    private int maas;
    private long calisanno;
    public int AsgariUcret = 17002;
    public string Adi
    {
        get { return adi; }
        set { adi = value.ToLower(); }
    }

    public string Soyadi
    {
        get { return soyadi; }
        set { soyadi = value.ToUpper(); }
    }

    public int Maas
    {
        get { return maas; }
        set { maas = value; }
    }

    public long Calisanno
    {
        get { return calisanno; }
        set { calisanno = value; }
    }

    public static void bilgiler(string adi, string soyadi, int maas, long calisanno,decimal asgariucret)
    {
        Console.WriteLine("calışan adı:{0}",adi);
        adi = Console.ReadLine();
        Console.Write("çalışan soyadı:{0}", soyadi);
        soyadi = Console.ReadLine();
        Console.WriteLine("calışan maaşı:{0}", maas);
        maas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("calışanın calışan numarası:{0}", calisanno);
        calisanno = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("bir çalışanın asgari ücreti:{0}",asgariucret);
    }

}