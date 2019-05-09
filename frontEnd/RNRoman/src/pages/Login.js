import React, { Component } from 'react';
import { StyleSheet, Text, View, } from 'react-native';

import { Header, Left, Icon } from 'native-base';

export default class LoginScreen extends Component {

    static navigationOptions = {
        drawerIcon : ({ tintColor }) => (
            <Icon name='person' style={{ fontSize : 24, color: tintColor }}/>
        )
    }
    render() {
        return (
            <View style={styles.container}>
                <Header style={{justifyContent: 'flex-start', backgroundColor: 'orange'}}>
                    <Left>
                        <Icon 
                        name='menu'
                        onPress={() => this.props.navigation.openDrawer()}/>
                    </Left>
                </Header>
                <View style={{flex:1, alignItems: 'center', justifyContent: 'center'}}>
                    <Text>Login Screen</Text>
                </View>
            </View>
        )
    }
};

const styles = StyleSheet.create({
    container: {
        flex: 1
    },
});