import { Directive, OnChanges, TemplateRef, ViewContainerRef, Input } from '@angular/core';

@Directive({
  selector: '[appNgForLoop]'
})
export class NgForLoopDirective implements OnChanges {

@Input('appNgForLoop') appNgForLoop : Array<any>;

  constructor(private container: ViewContainerRef,
    private template: TemplateRef<any>,
  ) { }

  ngOnChanges() {
    this.container.clear(); 

  for (const input of this.appNgForLoop){
    this.container.createEmbeddedView(this.template,  {
      $implicit: input,
      index: this.appNgForLoop.indexOf(input),
     });
  }
 }
}
