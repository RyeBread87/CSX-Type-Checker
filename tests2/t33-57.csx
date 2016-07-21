class testinc {
        ## must pass ##
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
		## This should pass ##
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

		## These should fail ##
                i = 3 + true;
                i = false - 4;
                i = false * '\t';
                i = 'a' / true;
                i = true + false;
                b = 3 + ~5;
                b = 3 - '\n';
                c = 'a' * ~200;
                c = '\\' / '\'';
                c = 3 && 'c';
                c = ~10 || true;
                c = !'c';
                i = true && false;
                b = true || true;
                b = !false;
                i = 3 + true * 'a';
                i = false - 4 + false * '\t';
                i = 'a' / true * (true + false);
                c = 3 && 'c' || ~10 || true && !'c';
                c = 1 < true;
                c = false > 2;
                c = 'a' <= false;
                c = true >= 'c';
                i = 1 < ~7;
                b = 2 > 'a';
        }

        ## must pass ##
        void g() {
                ## must pass ##
                int li;
                const lc = 'l';
                li = (int)false;
        }

        ## must pass ##
        char h() {
                ## must pass ##
                int li;

                ## must pass ##
                const lc = 'l';

                ## must pass ##
                {
                        char i;
                        int lc = 1;
                        g();  ## pass ##
                }
                return lc;
        }


        int returnfoo(int loc[]) {
                ## pass ##
                return i;
                return ai[5];
        }

        ## pass ##
        char methodName(int li, char lac[], bool lab[], 
                        int lai[], char la, bool lb) {
                ## pass ##
                ai = lai;
                lac = ac;
                ab = lab;
                lac = "not resoved until run-time\t";
                lb = lab[1000000];


                ## pass ##
                lac[li] = methodName(li, lac, lab, lai, la, lb); 

                ## pass ##
                lai[9] = (int)'c';
                la = (char)5;

                label1: while(lb) return (char)i;
		return 'c';
        }

        ## pass ##
        void main() {
                return;
        }

}
