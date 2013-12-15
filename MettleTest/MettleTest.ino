
int a=0;
int b=33;
int c=66;
uint32_t thistime;
int Statethis;

uint32_t LED1time;
uint32_t LED2time;
uint32_t LED3time;

int LED1;
int LED2;
int LED3;

bool pushbutton;

void setup() {
  Serial.begin(9600);

  Serial.println("*******Chart test V1.0*********");

  thistime = millis();
  LED1time = millis();
  LED2time = millis();
  LED3time = millis();
  
  LED1 = 1;
  LED2 = 2;
  LED3 = 3;
  
  Statethis = 1;
  
  pinMode(2, INPUT_PULLUP);
  //get the first read done
  pushbutton = digitalRead(2);
}

//return true if it's been period ms since start
bool IsTimedOut(uint32_t period, uint32_t start)
{
  uint32_t current = millis();
  return(current - start > period);
}

void SetThisState(int state)
{
  Serial.print(">Module1,This, State");
  Serial.print(state);
  Serial.println("<");
  
  Statethis = state;
}

void loop() 
{
  
 if(a++> 100) a=0;
 if(b++> 100) b=0;
 if(c++> 100) c=0;
 Serial.println("Line one");
 
 Serial.print(">Module2,Left,");
 Serial.print(a);
 Serial.println("<");
 
 Serial.print(">Module2,Right,");
 Serial.print(b);
 Serial.println("<");
 
 Serial.println("more lines n stuff");
 
 Serial.print(">Module2,XAxis,");
 Serial.print(analogRead(0));
 Serial.print("< ");
 
 Serial.print(">Module2,YAxis,");
 Serial.print(analogRead(1));
 Serial.print("<");
 
 Serial.print(">Module2,ZAxis,");
 Serial.print(analogRead(2));
 Serial.println("<");
 
 Serial.println("Last Line dontcha know");
  
 
 Serial.print(">Module2,Tag4,");
 Serial.print(c);
 Serial.print("< ");
 Serial.print("blah blah blah");
 
 Serial.print(">Module2,Tag4.5,");
 Serial.print("state_on");
 Serial.println("<");
 
 Serial.print("1234567890");
 
 Serial.print(">Module2,Tag4.6,");
 Serial.print("state_off");
 Serial.println("<");
 
 Serial.print(">Module2,with a space,");
   Serial.print("Space Here");
   Serial.println("<");
 
 if(digitalRead(2) != pushbutton)
 {
   //pressed is low
   pushbutton = digitalRead(2);
   
   Serial.print(">Module2,PushButton,");
   Serial.print(!pushbutton);
   Serial.println("<");
   
 }
  
  switch(Statethis)
  {
    case 1:
    if(IsTimedOut(1000, thistime))
    {
      SetThisState(3);
      thistime = millis();
    }
    break;
    case 2:
    if(IsTimedOut(1000, thistime))
    {
      SetThisState(4);
      thistime = millis();
    }
    break;
    case 3:
    if(IsTimedOut(1000, thistime))
    {
      SetThisState(2);
      thistime = millis();
    }
    break;
    case 4:
    if(IsTimedOut(1000, thistime))
    {
      SetThisState(1);
      thistime = millis();
    }
    break;
  }
  
  
  if(IsTimedOut(1000, LED1time))
  {
    Serial.print(">Module2,LED1,");
    Serial.print(LED1);
    Serial.println("<");
    LED1time = millis();
    
    LED1 = LED1?0:1;
    
    Serial.println(">badTag, one,good<");//actually a good tag
    Serial.println(">badTag, one,good<>badTag two,<");
    Serial.println(">badTag, one, bad");
    Serial.println(">badTag, one,<"); //is this bad??
    Serial.println(">badTag, one<");
    Serial.println(">badTag<");
    Serial.println("badTag, one,Bad too<");
  }
  
    if(IsTimedOut(2000, LED2time))
  {
    Serial.print(">Module2,LED2,");
    Serial.print(LED2);
    Serial.println("<");
    LED2time = millis();
    
    LED2 = LED2?0:1;
  }
  
    if(IsTimedOut(1500, LED3time))
  {
    Serial.print(">Module2,LED3,");
    Serial.print(LED3);
    Serial.println("<");
    LED3time = millis();
    
    LED3 = LED3?0:1;
  }
}
