#define S1 12
#define S2 11

#define LED1 10
#define LED2 9
#define LED3 8
#define LED4 7
#define LED5 6
#define LED6 5
#define LED7 4
#define LED8 3
#define LED9 2

int c4,c3,c2,c1,c0,c5,c6,c7,c8,s,b;
int m,c4m,c4c1,c4c3;
int arr[8], ant[8];

void setup() {
  pinMode(S1, INPUT);
  pinMode(S2, INPUT);
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(LED4, OUTPUT);
  pinMode(LED5, OUTPUT);
  pinMode(LED6, OUTPUT);
  pinMode(LED7, OUTPUT);
  pinMode(LED8, OUTPUT);
  pinMode(LED9, OUTPUT);
  
  Serial.begin(9600);
  Serial.println("Serial port open");
}

void loop() 
{
  delay(2000);
  ReadComponents();
  arr[0]=c4;
  arr[1]=c3;
  arr[2]=c2;
  arr[3]=c1;
  arr[4]=c0;
  arr[5]=c5;
  arr[6]=c6;
  arr[7]=c7;
  arr[8]=c8;

  for(int i=0; i<8; i++)
    ant[1]=arr[i];
  
  if((s==1 || s==0) && b==1)
  {
    arr[0]=SumaBinaria(arr[0],arr[1]);
    arr[1]=ant[2];
    arr[2]=SumaBinaria(arr[4],arr[3]);
    arr[3]=ant[4];
    arr[4]=SumaBinaria(arr[0],s);

    
    arr[2]=ant[3];
    arr[4]=ant[5];
    arr[6]=SumaBinaria(arr[0]+arr[1]);
    
    
    //c4=c4+c3;
    arr[0]+=arr[1];
    //c2=c4+c1;
    arr[0]+=arr[0];
  }
  
}

int SumaBinaria(int a, int b)
{
  int res;
  if(a==0 && b==0) res=1;
  else if()
  
  return res;
}


void ReadComponents()
{
  s = digitalRead(S1);
  b = digitalRead(S2);
  c4 = digitalRead(LED1);
  c3 = digitalRead(LED2);
  c2 = digitalRead(LED3);
  c1 = digitalRead(LED4);
  c0 = digitalRead(LED5);
  
  c5 = digitalRead(LED6);
  c6 = digitalRead(LED7);
  c7 = digitalRead(LED8);
  c8 = digitalRead(LED9);
}


