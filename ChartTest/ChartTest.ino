
int a=0;
int b=33;
int c=66;
uint32_t thistime;
int Statethis;

void setup() {
  Serial.begin(9600);

  Serial.println("*******Chart test V1.0*********");

  thistime = millis();
  
  Statethis = 1;
}

//return true if it's been period ms since start
bool IsTimedOut(uint32_t period, uint32_t start)
{
  uint32_t current = millis();
  return(current - start > period);
}

void SetThisState(int state)
{
  Serial.print(">This, State");
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
 
 Serial.print(">Left,");
 Serial.print(a);
 Serial.println("<");
 
 Serial.print(">Right,");
 Serial.print(b);
 Serial.println("<");
 
 Serial.println("more lines n stuff");
 
 Serial.print(">LAvg,");
 Serial.print(c);
 Serial.print("< ");
 
 Serial.print(">RAvg,");
 Serial.print("state_bob");
 Serial.println("<");
 
 Serial.println("Last Line dontcha know");
  
 
 Serial.print(">Tag4,");
 Serial.print(c);
 Serial.print("< ");
 Serial.print("blah blah blah");
 
 Serial.print(">Tag4.5,");
 Serial.print("state_on");
 Serial.println("<");
 
 Serial.print("1234567890");
 
 Serial.print(">Tag4.6,");
 Serial.print("state_off");
 Serial.println("<");
  
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
}
