## test13.misc ##
class test {
	int i;
	char c;
	bool b;
	const ic = 9;
	const cc = 's';
	const bc = true;
	int ia[3];
	char ca[5];
	bool ba[2];

	int f1(int p1, char p2, bool p3, int q1[], char q2[], bool q3[]) {
		int aa[9];
		char bb[9];
		aa[p1] = i;
		i = (int)p2;
		c = (char)p1;
		b = (bool)p1;
		c = aa[p2]; ## type mismatch ##
		i = aa[p3]; ## subscript error ##
		ia = (int)p3; ## type mismatch ##
		ca = (char)p3; ## type mismatch ##
		ba = (bool)p2; ## type mismatch ##
		bb[q1] = c; ## subscript error ##
		c = bb[q2]; ## subscript error ##
		c = bb[p3]; ## subscript error ##
		i = (int)q2; ## can't cast array ##
		c = (char)q3; ## can't cast array ##
		p1 = (int)"a"; ## can't cast stringLit ##
		ba = bb[i]; ## type mismatch ##
		b = bb[b]; ## subscript error ##
		b = bb[ia]; ## subscript error ##
		b = bb[ca]; ## subscript error ##
		b = bb[ba]; ## subscript error ##
		b = bb[f1]; ## subscript error ##
		b = bb[f2]; ## subscript error ##
		b = bb[f3]; ## subscript error ##
		b = bb[main]; ## subscript error ##
		b = bb[L]; ## subscript error ##
		i = (int)ba; ## can't cast array ##
		c = (char)ia; ## can't cast array ##
		i = (int)f2; ## can't cast method ##
		c = (char)f3; ## can't cast method ##
		i = (int)main; ## can't cast method ##
		c = (char)L; ## can't cast label ##
		i = (c + b) - i; ## only error for + ##
		i = c * (b / i); ## only error for / ##
		b = (c && b) || b; ## only error for && ##
		b = b && (b || i); ## oly error for || ##


		return 3;
	}

	char f2(int p1[], char p2[], bool p3[]) {

		return '3';
	}

	bool f3() {
		i = ia[9];
		c = ca['s'];
		i = ia[i + c];

		i = (int)bc;
		c = (char)ic;
		b = (bool)cc;

		i = (int)'c';
		c = (char)true;
		b = (bool)4;

		c = (char)(false);
		b = (bool)f2(ia, ca, ba);
		i = (int)f3();
		c = (char)f1(i, c, b, ia, ca, ba);
		
		return false;
	}

	void main() {
		bool bb[9];

		L: while(bb[2]) {
			break L;
		}

		return;
	}
}
