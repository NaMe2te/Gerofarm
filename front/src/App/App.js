import Header from "../components/header/Header";
import Footer from "../components/footer/Footer";
import Main from "../components/main/Main";
import Wrapper from "../components/wrapper/Wrapper";
import LeftPanel from "../components/main/left-panel/LeftPanel";
import Content from "../components/main/content/Content";
import RightPanel from "../components/main/right-panel/RightPanel";

function App() {
  return (
    <Wrapper>
        <Header />
        <Main>
            <LeftPanel />
            <Content />
            <RightPanel />
        </Main>
        <Footer />
    </Wrapper>
  );
}

export default App;
