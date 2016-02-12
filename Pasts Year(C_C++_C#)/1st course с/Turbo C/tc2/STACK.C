struct stack{
int n;
struct stack *sled;
}
push (struct stack **a,int k){
struct stack *nv;
nv=(struct stack *)malloc(sizeof(struct stack));
nv->n=k;
nv->sled=*a;
*a=nv;
}
pop(struct stack **a){
struct stack *old=*a;
int k;
if (old){
k=old->n;
*a=old->sled;
free(old);}
else {printf("Stack pustoY");
k=-10000;}
return k;}
main(){
struct stack *s=0;
push(&s,1);
push(&s,2);
push(&s,3);
printf("\n%d",pop(&s));
printf("\n%d",pop(&s));
push(&s,4);
printf("\n%d",pop(&s));
printf("\n%d",pop(&s));
printf("\n%d",pop(&s));
}