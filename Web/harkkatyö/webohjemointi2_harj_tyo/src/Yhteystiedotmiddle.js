import {useParams} from "react-router-dom";
import Yhteystiedot from './Yhteystiedot';

function Yhteystiedotmiddle(props){
    let params = useParams();
    return (

        <Yhteystiedot id={params.is}{...props}/>
        
        
        
        
        )

}

export default Yhteystiedotmiddle;