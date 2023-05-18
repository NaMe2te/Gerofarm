import style from "./Entity.module.css"

function Entity({key, title}) {
    if (title.length > 7)
        title = "..."
    return (
        <div className={style.entity} key={key}>
            {title}
        </div>
    )
}

export default Entity