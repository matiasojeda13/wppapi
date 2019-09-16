# WhatsAppApiUCU
Api para enviar mensajes por WhatsApp (usando Twilio)

Para utilizar esta biblioteca se deberá agregar una referencia a su proyecto y luego invocar el siguiente código:

```c#
var whatsApp = new WhatsAppApi(accountSid, authToken);
whatsApp.Send("+598<Poné tu teléfono acá>", "Hey! I'm using WhatsApp");
```

Reemplacen ``"<Poné tu teléfono acá>"`` por el número de teléfono de ustedes.

Agreguen a WhatsApp el siguiente contacto: +14155238886