import { Directive, ElementRef, HostListener } from "@angular/core";
import { ClickContext } from "../Classes/ClickContext";

@Directive({
  selector: '[appDecreaseFontTwice]'
})
export class DecreaseFontTwiceDirective {

  private htmlElement: HTMLElement;
  matMenuTimer: any;

  constructor(private el: ElementRef) {
    this.htmlElement = el.nativeElement;
  }

  @HostListener('dblclick') onClick() {
    clearTimeout(this.matMenuTimer);
    this.matMenuTimer = undefined;
    this.decrFontTwice();
  }

  decrFontTwice() {
    let currentFontSize = parseInt(window.getComputedStyle(this.htmlElement, null)
      .getPropertyValue('font-size').replace(/\D/g, ''));
    if (currentFontSize > 14) {
      this.htmlElement.style.fontSize = (currentFontSize / 2).toString() + "px";
    }
  }
}
