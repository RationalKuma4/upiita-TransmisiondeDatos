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
int c4,c3,c2,c1,c0,c5,c6,c7,M,s,b;
int arr[9]{0,0,0,0,0,0,0,0};
int ant[9]{0,0,0,0,0,0,0,0};

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
  b = digitalRead(S2);
  while (b == 0) 
  {
    s = digitalRead(S1);
    b = digitalRead(S2);
  }

  arr[5]=SumaBinaria(ant[0],ant[1]);
  arr[6]=SumaBinaria(ant[0],ant[3]);
  arr[7]=SumaBinaria(ant[0],s);
  arr[8]=s;
  arr[0]=arr[5];
  arr[1]=ant[2];
  arr[2]=arr[6];
  arr[3]=ant[4];
  arr[4]=arr[7];

  for(int i=0; i<9; i++)
  {
      ant[i]=arr[i];
  }

  /*Serial.println("Aneterior");
  for(int i=0; i<9; i++)
  {
    Serial.print(ant[i]);
  }
  Serial.println("");*/
  Serial.println("Array");
  for(int i=0; i<9; i++)
  {
    Serial.print(arr[i]);
  }
  Serial.println("");
  MostrarCodigo(arr);
}

int SumaBinaria(int a, int b)
{
  int res;
  if(a==0 && b==0) res=0;
  else if(a==0 && b==1) res=1;
  else if(a==1 && b==0) res=1;
  else res=0;
  return res;
}

void MostrarCodigo(int arr[])
{
  digitalWrite(LED1, arr[0]);
  digitalWrite(LED2, arr[1]);
  digitalWrite(LED3, arr[2]);
  digitalWrite(LED4, arr[3]);
  digitalWrite(LED5, arr[4]);
  digitalWrite(LED6, arr[5]);
  digitalWrite(LED7, arr[6]);
  digitalWrite(LED8, arr[7]);
  digitalWrite(LED9, arr[8]);
}


