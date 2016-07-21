class testinc {

        int i;
        char c;
        bool b;
        int ii = 7;
        int ai[4];
        char ac[10];
        bool ab[1];
        const ci = 1;
        const cc = 'c';
        const cb = true;

        void foo() {
                
                char b;
                bool c;
                i = 3 + ~5;
                i = 3 - '\n';
                i = 'a' * ~200;
                i = '\\' / '\'';
                
                
                c = true && false;
                c = true || true;
                c = !false;
                
                c = 1 < ~7;
                c = 2 > 'a';
                c = 'a' <= ~100;
                c = '\n' >= 'b';
                c = true == false;
                c = false != false;

        }
        

        
        void g() {
                
                int li;
                const lc = 'l';
                li = (int)false;
        }


        char h() {
                
                int li;

                
                const lc = 'l';

                
                {
                        char i;
                        int lc = 1;
                        g();  
                }

                foo();
                return lc;
        }

        void func(char i, int j, bool boo[]) {
                
                bool cb;
                char tmp = ac[1];
                bool localboo = cb;
                int localint = ~5;
                const localarray = boo[1];

                
                i = 'c';
                if (cb) { int cb; cb = 1;}
                if (true) return;
                else {
                        print(1);
                        print('c');
                        print(true);
                        print(ii);  
                        print(i);  
                        print(cb);  
                        print(ai[0]);  
                        print(ac[0]);  
                        print(ab[0]);  
                        print(ac);  
                        
                        

                        read(ii);  
                        read(i);  
                        read(ai[0]);  
                        read(ac[0]);  
                }

                
                ii = ci * ac[0];
                ab[0] = ab['a'];  

                
                while (false) return;

                begin: while (boo['c']) {
                        bool tmp = boo[1];
                        break begin;
                }

		{
                        
                        int lai[4];
                        int laii[10];
                        char lac[10];
                        char lacc[1];
                        bool lab[1];
                        bool labb[4];

                        
                        ai = lai;
                        ac = lac;
                        ab = lab;


                        
                        ac  = "0123456789";
                        lac = "          ";
                        lac = "a@\"c\\\t\n.\\\n";
                        lacc = " ";
                        lacc = "\t";
                        lacc = "\n";
                        lacc = "\\";
                        lacc = "\"";

                }

                
                return;

        }

        int returnfoo(int loc[]) {
                
                return i;
                return ai[5];

        }

        
        int m(char m) {
		int arr1[6];
		int arr2[6];
                arr1 = arr2;
                m = 'c';

                
                l1: while (true) {
                        
                        
                        
                        break l1;
                        continue l1;
                }
        }

        
        bool mm(int i) {
	  return false;
        }

        
        char methodName(int li, char lac[], bool lab[], 
                        int lai[], char la, bool lb) {

                ai = lai;
                lac = ac;
                ab = lab;
                lac = "not resoved until run-time\t";
                lb = lab[1000000];

                
                lab[li] = mm(lai[la]);
                lac[li] = methodName(li, lac, lab, lai, la, lb); 

                
                func(la, li, ab);
                func(la, lai[0], ab);

                
                b = (bool)mm((int)lac[0]);
                lai[9] = (int)((char)mm(lai[0]));
                la = (char)5;

                label1: while(lb) return (char)i;

        }

        
        void main() {
                return;
        }
}
