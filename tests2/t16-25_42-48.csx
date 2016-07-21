## test6.read-print ##
class test {
	int i;
	char c;
	bool b;
	int ia[3];
	char ca[8];
	bool ba[8];

	int f1(int p1, char p2, bool p3) {
		print(p1, p2, p3);
		return 0;
	}

	char f2(int p1[], char p2[], bool p3[], int q1, char q2, bool q3) {
		read(q1, q2, q3); ## can't read q3 ##
		read(p1, p2, p3); ## can't read p1, p2, p3 ##
		print(p1, p2, p3); ## can't print p1, p3 ##
		read(c, b); ## can't read b ##
		read(ia, ca, ba); ## can't read ia, ca, ba ##
		read(f1, f2); ## can't read f1, f2 ##
		read(main, L); ## can't read main, L, not yet declared ##
		print(b, ia, ca, ba); ## can't print ia, ba ##
		print(f1, f2, f3); ## can't print f1, f2, f3 ##
		print(main, L); ## can't print main, L ##
		return 'c';
	}

	bool f3() {
		return true;
	}

	void main() {
		L: while(b) {
			continue L;
		}

		read(i);
		print(10);
		print('c', false);
		print("string", i, c);
		read(c, b); ## can't read b ##
		read(ia, ca, ba); ## can't read ia, ca, ba ##
		read(f1, f2, f3); ## can't read f1, f2, f3 ##
		read(main, L); ## can't read main, L ##
		print(b, ia, ca, ba); ## can't print ia, ba ##
		print(f1, f2, f3); ## can't print f1, f2, f3 ##
		print(main, L); ## can't print main, L ##
	}
}
