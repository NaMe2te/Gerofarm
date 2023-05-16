import style from "./Main.module.css"
import LeftPanel from "./left-panel/LeftPanel";
import Content from "./content/Content";
import RightPanel from "./right-panel/RightPanel";

function Main () {
    return (
        <main className={style.main}>
            <LeftPanel />
            <Content />
            <RightPanel />
        </main>
    )
}

export default Main