main(int ARGC, char **ARGV){
printf("\n %c   ",ARGV[1][0]);
switch(ARGV[1][0]) {
case '1': printf ("-1"); break;
case '2': printf("-2"); break;
case 'h':printf("BBedite -1 ili -2"); break;
default: printf("Error, type -h for help");};
getch();
}