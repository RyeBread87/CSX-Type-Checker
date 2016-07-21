## test4.assignment ##

class Test {
  	int aaa;
  	char s;
  	bool bbb;
	const c = 3;

	int ia1[5];
	char ca1[5];
	bool ba1[5];

	int ia2[4];
	char ca2[8];
	bool ba2[3];
	void f0() { return; }

	int f1(int p1, bool p2, char p3) {
		aaa = p1;
		p1 = aaa;
		bbb = p2;
		p2 = bbb;
		s = p3;
		p3 = s;
		p1 = ia1;	## type mismatch ##
		p2 = ba1;	## type mismatch ##
		p3 = ca1;	## type mismatch ##
		ia1 = p1;	## type mismatch ##
		ba2 = p2; 	## type mismatch ##
		ca1 = p3;	## type mismatch ##
		c = 8;		## assignment to const ##
  		aaa = true;	## type mismatch ##
  		aaa = "foo";	## type mismatch ##
  		aaa = bbb;	## type mismatch ##
  		aaa = s;	## type mismatch ##
		aaa = ia1;	## type mismatch ##
		aaa = f1;	## type mismatch ##
		ia1 = ia2;	## different array size ##
		ia1 = f1;	## type mismatch ##
  		bbb = 1;	## type mismatch ##
  		bbb = "foo";## type mismatch ##	
  		bbb = aaa;	## type mismatch ##
  		bbb = s;	## type mismatch ##
		bbb = ba1;	## type mismatch ##
		bbb = f2;	## f2 undeclared ##
		ba1 = ba2;	## different array size ##
		ba1 = f2;	## f2 undeclared ##
  		s = 1;	## type mismatch ##
  		s = true;	## type mismatch ##
  		s = "foo";	## type mismatch ##
  		s = aaa;	## type mismatch ##
  		s = bbb;	## type mismatch ##
		s = ca1;	## type mismatch ##
		s = f3;	## f3 undeclared ##
		ca1 = ca2;	## different array size ##
		ca1 = "bad";	## different array size ##
		ca1 = "bad\\";	## different array size ##
		ca1 = f3;	## f3 undeclared ##
		f1 = aaa;	## type mismatch ##
		f1 = ia1;	## type mismatch ##
		f1 = f1;	## type mismatch ##
		f2 = bbb;	## f2 undeclared ##
		f2 = ba1;	## f2 undeclared ##
		f3 = s;		## f3 undeclared ##
		f3 = ca1;	## f3 undeclared ##
		f3 = f0;	## f3 undeclared ##
		ia1 = ca1;	## type mismatch ##
		ca1 = ba1;	## type mismatch ##
		ba1 = ia1;	## type mismatch ##
  		aaa = f0;       ## type mismatch ##
  		f0 = 0;	       ## type mismatch ##
  		f0 = f0;       ## type mismatch ##
		ia2 = f0;       ## type mismatch ##
		f0 = ba2;       ## type mismatch ##
		f0 = f1;       ## type mismatch ##
		f0 = f2;       ## f2 undeclared ##
		f0 = f3;       ## f3 undeclared ##
		L = aaa;	## L undeclared ##
		bbb = L;	## L undeclared ##
		L = f0;	## L undeclared ##
		f0 = L;	## L undeclared ##
		L = L;	## L undeclared ##		

		return p1;
	}

	bool f2(int p1[], bool p2[], char p3[]) {
		p1 = ia1;
		ia1 = p1;
		p2 = ba1;
		ba2 = p2;
		p3 = ca1;
		p3 = "aaa";
		ca1 = p3;
		return true;
	}

	char f3() {
		return 's';
	}


	void main() {
  		aaa = 1;
		L: while (true) {
			continue L;
		}
	}

}
