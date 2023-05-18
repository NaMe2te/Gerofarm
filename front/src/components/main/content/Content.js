import Entity from "./entity/Entity";
import "./Content.css"
import {useEffect, useState} from "react";
import axios from 'axios';


function Content() {

    const panelWidth = 150;
    const panelHeight = 100;
    const panelMargin = 20;
    const containerWidth = window.innerWidth - 450;
    const containerHeight = window.innerHeight - 150;
    const maxPanelsInRow = Math.floor(containerWidth / (panelWidth + panelMargin));
    const maxPanelsInColumn = Math.floor(containerHeight / (panelHeight + panelMargin));
    const maxPanels = maxPanelsInColumn * maxPanelsInRow;

    const [panels, setPanels] = useState([]);
    const [isFirstRun, setIsFirstRun] = useState(true);

    const getPanels = (getPostsCount, alreadyPostsExistCount) => {
        axios.get(`https://localhost:44392/api/Post/get-posts?getPostsCount=${getPostsCount}&alreadyPostsExistCount=${alreadyPostsExistCount}`)
            .then((resp) => {
                const newPanels = resp.data.map((panel) => (
                    <Entity key={panel.id} title={panel.title} />
                ));
                setPanels((prevPanels) => [...prevPanels, ...newPanels]);
            });
    }

    useEffect(() => {
        if (isFirstRun) {
            getPanels(maxPanels, 0);
            setIsFirstRun(false);
        }
    }, []);

    
    useEffect(() => {
        const updatePanels = () => {
            const containerWidth = window.innerWidth - 450;
            const containerHeight = window.innerHeight - 150;
            const maxPanelsInRow = Math.floor(containerWidth / (panelWidth + panelMargin));
            const maxPanelsInColumn = Math.floor(containerHeight / (panelHeight + panelMargin));
            const maxPanels = maxPanelsInColumn * maxPanelsInRow;
            const remainingPanels = panels.length - maxPanels;

            if (remainingPanels > 0) {
                setPanels(panels.slice(0, maxPanels));
            } else if (remainingPanels < 0) {
                const getPostsCount = Math.abs(remainingPanels);
                const alreadyPostsExistCount = panels.length;

                getPanels(getPostsCount, alreadyPostsExistCount);
            }
        };

        updatePanels();

        window.addEventListener('resize', updatePanels);

        return () => {
            window.removeEventListener('resize', updatePanels);
        };

    }, [panels]);

    const viewPanels = () => {
        const generatedPanels = [];

        for (let i = 0; i < maxPanels; i++) {
            generatedPanels.push(
                panels[i]
            );
        }

        return generatedPanels;
    };

    return(
        <div className="content">
            {viewPanels()}
        </div>
    );
}

export default Content