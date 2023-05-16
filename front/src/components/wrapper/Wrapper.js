import style from "./Wrapper.module.css"


function Wrapper({children}) {
    return(
    <div className={style.wrapper}>
        {children}
    </div>
    )
}

export default Wrapper