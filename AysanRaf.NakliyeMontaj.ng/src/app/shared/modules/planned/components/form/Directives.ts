import { Directive, ElementRef, HostListener } from '@angular/core';
import { NgControl } from '@angular/forms';

@Directive({
  selector: '[uppercaseOnly]'
})
export class UppercaseOnlyDirective {

  constructor(private el: ElementRef, private control: NgControl) { }

  @HostListener('input', ['$event']) onInput(event: any) {
    // NgControl null kontrolü
    if (this.control) {
      const inputValue: string = this.el.nativeElement.value;
      this.control.control?.setValue(inputValue.toUpperCase(), { emitEvent: false });
    }
  }
}
