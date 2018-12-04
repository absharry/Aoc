import * as React from 'react';
import Header from './header';
import Day from './day';
import Home from './home';
import { Route, BrowserRouter } from 'react-router-dom';

class Layout extends React.Component<{}> {
    public render() {
        return (
            <div className="container">
                <Header></Header>
                <div className="row">
                    <div className="col-12">
                        <h1>Advent of Code</h1>
                    </div>
                </div>
                <div className="row">
                    <div className="col-12">
                        <div className="content">
                            <Route exact path="/" component={Home} />
                            <Route path='/:year/:day' component={Day} />
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default Layout;