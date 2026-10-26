import { Component } from "react";

class Yhteystiedot extends Component {
    render(){       
        return(
            <div>

                <p>Tämä on yhteystiedot sivu{this.props.id }</p>
                {this.props.name ? <p>{this.props.name}</p>:null}
            </div>

         )

    }

}
export default Yhteystiedot;