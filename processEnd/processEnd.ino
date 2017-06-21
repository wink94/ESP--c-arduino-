int led = 8;

void setup() {
 Serial.begin(9600);
 pinMode(led, OUTPUT);
 Serial.flush();
 
}

void loop() {



if ( Serial.available() >0) {
  char input= Serial.read();

  if (input == '1') {
    digitalWrite(led,HIGH);
    }
    
  if (input == '0') {
    digitalWrite(led,LOW);
    }

  Serial.println(input);
  
  }

}
