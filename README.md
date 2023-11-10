# Ceaser-cipher program

```

Origin:
The Caesar cipher dates back to ancient Rome, around 58 BCE to 50 BCE, during the time of Julius Caesar. According to historical accounts, Julius Caesar is said to have used a simple substitution cipher to encrypt his private messages.

Encryption Method:
The Caesar cipher is a substitution cipher where each letter in the plaintext is shifted a certain number of places down or up the alphabet. The key in this cipher is the number of positions each letter is shifted.

Algorithm:

Choose a shift value (the key).
For each letter in the plaintext, shift it by the specified number of positions.
Wrap around the alphabet if necessary (e.g., shifting "z" by 1 results in "a").
Maintain the case of the letters (uppercase or lowercase).
Example:
If the shift is 3, the letter "A" becomes "D," "B" becomes "E," and so on. The process continues until the end of the alphabet.

Plain: ABCDEFGHIJKLMNOPQRSTUVWXYZ
Cipher: XYZABCDEFGHIJKLMNOPQRSTUVW

Weakness:
The Caesar cipher is a very weak encryption method by modern standards. There are only 25 possible keys (1 to 25), making it susceptible to brute force attacks. With today's computing power, it can be easily decrypted.
```
