struct och{
int n;
struct och *sled;
} *s,*end;
push (int k){
struct och *nv;
nv=(struct och *)malloc(sizeof(struct och));
nv->n=k;
if(s)
end->sled=nv;
else
s=nv;
end=nv;
nv->sled=0;
}
pop(){
struct och *old=s;
int k;
if (old){
k=old->n;
s=old->sled;
free(old);}
else {printf("Stack pustoY");
k=-10000;}
return k;}
main(){
struct och *s=0;
clrscr();
push(1);
push(2);
push(3);
printf("\n%d",pop(&s));
printf("\n%d",pop(&s));
push(4);
printf("\n%d",pop(&s));
printf("\n%d",pop(&s));
printf("\n%d",pop(&s));
}