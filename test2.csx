class test {
## sample test program for proj #4 (type checker) --
   may not execute correctly ##


int f(){}
int f(int i){}
int f(char i){}
int f(int i,int j){}
bool f(){}
void f(){}
int f(){}
int f(int i){}
void g(){}
void g(int i){}
void main(){
 int i;
 g();
 g(1);
 g(1,2);
 i=f();
 i=f(1);
 i=f(1,2,3);
}
} // That's all folks
