# Labo 5 - Events

## Deel 1
- Maak een event procedure voor het click event van de *showMessageButton*
- Toon een *MessageBox* met de tekst "Er werd op de knop geklikt"
	``` 
	MessageBox.Show("Er werd op de knop geklikt"); 
	```

- Zorg ervoor dat dezelfde event procedure wordt uitgevoerd wanneer er op de *showAgainButton* geklikt wordt
- Wijzig nu de tekst van de MessageBox zodat de naam van de knop waar op geklikt werd wordt weergegeven als volgt:

	![Afbeelding](media/button_clicked.png)

	Gebruik slechts ��n event procedure voor beide knoppen!
	> Tip: Gebruik de *sender* parameter van de event procedure

## Deel 2
- Maak een event procedure voor het *KeyDown* event van de *nameTextBox*
- Toon het karakter dat werd ingegeven in de *nameTextBox* in het *nameOutputLabel*

	![Afbeelding](media/textbox_keydown.png)

- Wijzig de achtergrondkleur van de *nameTextBox* wanneer ��n van de functietoetsen wordt ingedrukt (F1 - F12), gebruik hiervoor de **reeds bestaande** functie *GetRandomColorBrush()*
	> Tip: Gebruik *Key* eigenschap van de *e* parameter van de event procedure
- Toon nu een MessageBox met de volledige naam wanneer de *Enter* toets wordt ingedrukt
	
	![Afbeelding](media/textbox_enter.png)

## Deel 3
- Zorg ervoor dat alle alfanumerische (A-Z) karakters die worden ingegeven in de *originalTextBox* worden omgezet naar hoofdletters of omgekeerd. Toon de output in het *convertedLabel*
	
	![Afbeelding](media/keydown_modifiers.png)

## Deel 4
- Maak **��n** event procedure met de naam *counterButton_Click* en zorg dat deze wordt uitgevoerd bij het click-event van de 3 buttons: *firstButton*, *secondButton* en *thirdButton**
- Bepaal in de event procedure welke knop werd ingedrukt
- Verhoog het nummer wat wordt weergegeven als tekst van de knop met 1

![Afbeelding](media/counterbuttons.png)