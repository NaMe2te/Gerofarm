import style from "./Content.module.css"
import Entity from "./entity/Entity";

function Content() {
    return(
    <div className={style.content}>
        <Entity />
    </div>
    );
}

export default Content