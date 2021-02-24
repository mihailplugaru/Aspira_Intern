export class ClickContext {

    private static instance: ClickContext;

    private constructor() { }

    public static getInstance(): ClickContext {
        if (!ClickContext.instance) {
            ClickContext.instance = new ClickContext();
        }
        return ClickContext.instance;
    }

    clickHandler(handler: ClickHandler): ClickHandler {
        return function() {
            const args = arguments;
            this.isSingleClick = true;
            setTimeout(() => {
                this.isSingleClick && handler.apply(undefined, args);
            }, 850);
        }
    }

    dblClickHandler(handler: ClickHandler): ClickHandler {
        return function() {
            const args = arguments;
            this.isSingleClick = false;
            setTimeout(() => {
                this.isSingleClick = true;
            }, 850);
            handler.apply(undefined, args);
        }
    }
}

type ClickHandler = (...any) => void;