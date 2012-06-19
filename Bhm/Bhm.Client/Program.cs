using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

using Bhm.Client.PegawaisService;
//using Bhm.Client.PosyandusService;
//using Bhm.Client.BalitasService;

namespace Bhm.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PegawaisServiceClient proxyPegawai = new PegawaisServiceClient();

            Console.WriteLine("Daftar semua pegawai");
            string[] pegawaiNames = proxyPegawai.ListPegawai();
            foreach (string pegawaiName in pegawaiNames)
                Console.WriteLine("Nama: {0}", pegawaiName);
            Console.WriteLine();

            Console.WriteLine("Detail pegawai");
            PegawaiData pegawai = proxyPegawai.GetPegawai("Fariani Dewi Y");
            Console.WriteLine("ID: {0}", pegawai.idPgw);
            Console.WriteLine("Nama: {0}", pegawai.namaPgw);
            Console.WriteLine("Instansi: {0}", pegawai.instansi);
            Console.WriteLine("Username: {0}", pegawai.usernamePgw);
            Console.WriteLine("Password: {0}", pegawai.passwordPgw);
            Console.WriteLine();

            PegawaiData pegawaiLogin = proxyPegawai.CheckLogin("yati", "yati");
            Console.WriteLine("ID: {0}", pegawaiLogin.idPgw);
            Console.WriteLine("Nama: {0}", pegawaiLogin.namaPgw);
            Console.WriteLine("Instansi: {0}", pegawaiLogin.instansi);
            Console.WriteLine("Username: {0}", pegawaiLogin.usernamePgw);
            Console.WriteLine("Password: {0}", pegawaiLogin.passwordPgw);
            Console.WriteLine();

            proxyPegawai.Close();

            //PosyandusServiceClient proxyPosyandu = new PosyandusServiceClient();

            //Console.WriteLine("Daftar semua posyandu");
            //string[] posyanduNames = proxyPosyandu.ListPosyandu();
            //foreach (string posyanduName in posyanduNames)
            //    Console.WriteLine("Nama: {0}", posyanduName);
            //Console.WriteLine();

            //Console.WriteLine("Detail posyandu");
            //PosyanduData posyandu = new PosyanduData();
            //posyandu = proxyPosyandu.GetPosyandu("Informatika");
            //Console.WriteLine("ID: {0}", posyandu.idPosyandu);
            //Console.WriteLine("Nama: {0}", posyandu.namaPosyandu);
            //Console.WriteLine("Desa: {0}", posyandu.desaPosyandu);
            //Console.WriteLine("Kecamatan: {0}", posyandu.kecPosyandu);
            //Console.WriteLine("Kabupaten: {0}", posyandu.kabPosyandu);
            //Console.WriteLine("Provinsi: {0}", posyandu.provPosyandu);

            //proxyPosyandu.Close();
            
            //BalitasServiceClient proxyBalita = new BalitasServiceClient();
            //proxyBalita.insert_balita();
            //proxyBalita.Close();

            //Console.ReadLine();
        }
    }
}
