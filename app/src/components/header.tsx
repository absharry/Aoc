import * as React from 'react';
import { NavLink } from 'react-router-dom';

export class Header extends React.Component<{}> {
    
    public render() {
        return <header>
            <ul className="header">
                <li><NavLink exact to="/">Home</NavLink> </li>
            </ul>
        </header>;
    }
}

export default Header;