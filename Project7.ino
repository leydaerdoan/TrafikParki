int red = 8; 
int yellow = 9; 
int green = 10;

int trigPin = 7;
int echoPin = 6;
float uzaklik;
long sure;
int time;

int TCRT5000=4;

String val1,val2,val3;

int metre1 = 0, metre2 = 0;
float fark = 0;

void setup()
{

  Serial.begin(9600);

  pinMode(red, OUTPUT);
  pinMode(yellow, OUTPUT);
  pinMode(green, OUTPUT);

  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);

  pinMode(TCRT5000,INPUT);
  
  time = 0;

}

 void loop()
{
    changeLights();
}


void changeLights()
{
    time = time +1 ;
   
    
    if(time <= 6)
    {
      
      digitalWrite(red, HIGH);
      Serial.print("Kirmizi");
      Serial.print("*");
      val1=("Kırmızı");
    }
    else if(time >= 6 && time <= 8)
    {
      digitalWrite(yellow, HIGH);
      digitalWrite(red, HIGH);
      Serial.print("Sari");
      Serial.print("*");
       val1=("Sarı");
      
    }
    else if (time >= 8 && time <= 13)
    {
      digitalWrite(yellow, LOW);
      digitalWrite(red, LOW);
      digitalWrite(green, HIGH);
      Serial.print("Yesil");
      Serial.print("*");
       val1=("Yeşil");
    }
    else if( time >= 13 && time <= 14)
    {
      digitalWrite(yellow, HIGH);
      digitalWrite(red, LOW);
      digitalWrite(green, LOW);
      Serial.print("Sari");
      Serial.print("*");
       val1=("Sarı");
      
      
    }

    distance();
    delay(1000);
    metre2=uzaklik;
    
    if(time >= 14)
    {
      digitalWrite(yellow, LOW);
      digitalWrite(red, LOW);
      digitalWrite(green, LOW);
      time = 0;
    }

}

void distance()
{
    
    digitalWrite(trigPin, LOW);
    delayMicroseconds(5);
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);
    sure = pulseIn(echoPin, HIGH);
    uzaklik = sure / 2 / 29.1;
    if(uzaklik > 200)
    uzaklik = 200;
    metre1=uzaklik;

    int bilgi_d=digitalRead(TCRT5000);
    int bilgi_a=analogRead(A0);

    //Serial.print(uzaklik/100);
    Serial.print(fark/10);
    Serial.print(" km/h");
    Serial.print("*");
    //Serial.print(uzaklik/100);
    //Serial.print(" m");
    //Serial.print("*");
    val2=analogRead(A2);
    if(bilgi_a > 600){
    Serial.println("Yok");
    val3=analogRead(A3);
    }
    else{
    Serial.println("Var");
    val3=analogRead(A3);
    }

   fark=abs(metre2-metre1);

}

