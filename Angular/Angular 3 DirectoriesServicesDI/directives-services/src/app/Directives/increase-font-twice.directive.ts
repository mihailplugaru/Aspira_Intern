import { Directive, ElementRef, HostListener } from "@angular/core";

@Directive({
  selector: '[appIncreaseFontTwice]'
})
export class IncreaseFontTwiceDirective {

  private htmlElement: HTMLElement;
  matMenuTimer: any;

  constructor(private el: ElementRef) {
    this.htmlElement = el.nativeElement;
  }

  @HostListener('click') onClick() {
    this.matMenuTimer = setTimeout(() => { this.incrFontTwice(); }, 300);
  }

  @HostListener('dblclick') onDoubleClick() {
    clearTimeout(this.matMenuTimer);
    this.matMenuTimer = undefined;
  }

  incrFontTwice() {
    if (!this.matMenuTimer) return;
    let currentFontSize = parseInt(window.getComputedStyle(this.htmlElement, null)
      .getPropertyValue('font-size').replace(/\D/g, ''));
    if (currentFontSize < 112) {
      this.htmlElement.style.fontSize = (currentFontSize * 2).toString() + "px";
    }
  }
}
