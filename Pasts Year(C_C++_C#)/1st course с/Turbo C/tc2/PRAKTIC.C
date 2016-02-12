#include<conio.h>
#include<stdio.h>
#include<alloc.h>
struct t { char ip[20];
	   char mask[20];
	   char gate[20];
	  };

main() {
int i,k=0;                         /*Переменные дл циклов*/
char a[20];                        /*строка дл печати*/
struct t *u;                       /*дополнительна  запись*/
FILE *in,*out;                      /*Объвлем файловые потоки*/
if((out=fopen("routex.cmd","r"))==NULL){   /*Присваеваем потоку файл, и проверем его существование*/
  printf("\nNO FILE FOUND");
  exit(1);};
in=fopen("ff2.sh","w");
fscanf(out,"%s%s",a,a);
fprintf(in,"#!/bin/bash\n");
while(!feof(out)){                               /*Основной цикл*/
  fscanf(out,"%s%s%s%s%s%s%s",a,a,a,u->ip,a,u->mask,u->gate); /*Считываем в структуру строку из основного файла*/
  fprintf(in,"sudo route add -net %s netmask %s gw %s\n",u->ip,u->mask,u->gate);

  };
}