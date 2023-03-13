int a1 = 12;
int b1 = 23;
int c1 = 33;
int a2 = 13;
int b2 = 24;
int c2 = 35;
int a3 = 14;
int b3 = 25;
int c3 = 316;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine (max);

