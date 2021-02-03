using System.IO;
using System.Diagnostics;

namespace ReadFiles
{
    class Program
    {

        static void Main(string[] args)
        {
            F1(args);
        }

        static void F1(string[] args)
        {
            if (args.Length > 2)
            {
                SimpleLib simpleLib;
                simpleLib = new SimpleLib();

                string file1;
                file1 = simpleLib.f1(args[0]);

                string file2;
                file2 = simpleLib.f1(args[1]);

                string file3;
                file3 = args[2];

                string ff1;
                ff1 = file1;

                int val1;
                val1 = simpleLib.f2(ff1);

                string ff2;
                ff2 = file2;

                int val2;
                val2 = simpleLib.f2(ff2);

                string ff3;
                ff3 = file3;

                int val3;
                val3 = simpleLib.f2(ff3);

                int val5;
                val5 = val1;

                int val6;
                val6 = val2;

                int val7;
                val7 = val3;
                Debug.Assert(simpleLib.x == val5 + val6 + val7);
            }
        }

        private class SimpleLib
        {
            public int x;

            public SimpleLib()
            {
                x = 0;
            }

            public string f1(string rootFile)
            {
                string fn;
                using (StreamReader reader = new StreamReader(rootFile))
                {
                    fn = reader.ReadToEnd();
                }
                // ... A slow-running computation.
                string fnn;
                fnn = fn;
                return fnn;
            }

            public int f2(string file)
            {
                int r1;
                using (StreamReader reader = new StreamReader(file))
                {
                    string v;
                    v = reader.ReadToEnd();
                    r1 = x;

                    string vv;
                    vv = v;
                    r1 += 2 * vv.Length;

                    // ... A slow-running computation.
                    x = r1;
                    return 2 * vv.Length;
                }
            }
        }
    }
}
